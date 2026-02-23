using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Paucituberculata.Caenolestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Paucituberculata.Caenolestidae.Rhyncholestes;

/// <summary>
/// Abstract class for Rhyncholestes (genus).
/// NCBI TaxId: 33558
/// </summary>
public abstract class Rhyncholestes : Caenolestidae, IRhyncholestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhyncholestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33558;

    /// <inheritdoc />
    public virtual string GenusName => "Rhyncholestes";

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
