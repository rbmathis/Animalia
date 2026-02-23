using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Lophotibis;

/// <summary>
/// Abstract class for Lophotibis (genus).
/// NCBI TaxId: 1706832
/// </summary>
public abstract class Lophotibis : Threskiornithidae, ILophotibis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophotibis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1706832;

    /// <inheritdoc />
    public virtual string GenusName => "Lophotibis";

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
