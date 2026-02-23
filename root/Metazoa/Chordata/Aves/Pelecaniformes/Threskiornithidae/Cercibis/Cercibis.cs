using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Cercibis;

/// <summary>
/// Abstract class for Cercibis (genus).
/// NCBI TaxId: 3150853
/// </summary>
public abstract class Cercibis : Threskiornithidae, ICercibis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cercibis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150853;

    /// <inheritdoc />
    public virtual string GenusName => "Cercibis";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
