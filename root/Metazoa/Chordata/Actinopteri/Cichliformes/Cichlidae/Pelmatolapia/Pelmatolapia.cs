using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pelmatolapia;

/// <summary>
/// Abstract class for Pelmatolapia (genus).
/// NCBI TaxId: 1315719
/// </summary>
public abstract class Pelmatolapia : Cichlidae, IPelmatolapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelmatolapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1315719;

    /// <inheritdoc />
    public virtual string GenusName => "Pelmatolapia";

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
