using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Bycanistes;

/// <summary>
/// Abstract class for Bycanistes (genus).
/// NCBI TaxId: 175842
/// </summary>
public abstract class Bycanistes : Bucerotidae, IBycanistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bycanistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175842;

    /// <inheritdoc />
    public virtual string GenusName => "Bycanistes";

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
