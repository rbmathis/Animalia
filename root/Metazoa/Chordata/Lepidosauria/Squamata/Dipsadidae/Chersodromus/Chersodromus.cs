using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Chersodromus;

/// <summary>
/// Abstract class for Chersodromus (genus).
/// NCBI TaxId: 1212555
/// </summary>
public abstract class Chersodromus : Dipsadidae, IChersodromus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chersodromus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1212555;

    /// <inheritdoc />
    public virtual string GenusName => "Chersodromus";

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
