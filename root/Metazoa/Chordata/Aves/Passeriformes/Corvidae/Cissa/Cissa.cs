using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Cissa;

/// <summary>
/// Abstract class for Cissa (genus).
/// NCBI TaxId: 56791
/// </summary>
public abstract class Cissa : Corvidae, ICissa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cissa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56791;

    /// <inheritdoc />
    public virtual string GenusName => "Cissa";

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
