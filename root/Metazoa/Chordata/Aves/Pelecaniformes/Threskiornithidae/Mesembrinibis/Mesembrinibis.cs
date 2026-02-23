using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Mesembrinibis;

/// <summary>
/// Abstract class for Mesembrinibis (genus).
/// NCBI TaxId: 1118747
/// </summary>
public abstract class Mesembrinibis : Threskiornithidae, IMesembrinibis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesembrinibis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1118747;

    /// <inheritdoc />
    public virtual string GenusName => "Mesembrinibis";

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
