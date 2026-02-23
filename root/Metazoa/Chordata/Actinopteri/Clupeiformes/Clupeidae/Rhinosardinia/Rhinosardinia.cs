using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Rhinosardinia;

/// <summary>
/// Abstract class for Rhinosardinia (genus).
/// NCBI TaxId: 521037
/// </summary>
public abstract class Rhinosardinia : Clupeidae, IRhinosardinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinosardinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 521037;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinosardinia";

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
