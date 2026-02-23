using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Buceros;

/// <summary>
/// Abstract class for Buceros (genus).
/// NCBI TaxId: 175829
/// </summary>
public abstract class Buceros : Bucerotidae, IBuceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Buceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175829;

    /// <inheritdoc />
    public virtual string GenusName => "Buceros";

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
