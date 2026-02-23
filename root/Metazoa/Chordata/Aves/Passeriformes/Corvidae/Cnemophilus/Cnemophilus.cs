using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Cnemophilus;

/// <summary>
/// Abstract class for Cnemophilus (genus).
/// NCBI TaxId: 108822
/// </summary>
public abstract class Cnemophilus : Corvidae, ICnemophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cnemophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 108822;

    /// <inheritdoc />
    public virtual string GenusName => "Cnemophilus";

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
