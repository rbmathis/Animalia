using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Laemolyta;

/// <summary>
/// Abstract class for Laemolyta (genus).
/// NCBI TaxId: 1396885
/// </summary>
public abstract class Laemolyta : Anostomidae, ILaemolyta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laemolyta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1396885;

    /// <inheritdoc />
    public virtual string GenusName => "Laemolyta";

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
