using AnimalKingdom.root.Metazoa.Chordata.Testudines.Dermochelyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Dermochelyidae.Dermochelys;

/// <summary>
/// Abstract class for Dermochelys (genus).
/// NCBI TaxId: 27793
/// </summary>
public abstract class Dermochelys : Dermochelyidae, IDermochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dermochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27793;

    /// <inheritdoc />
    public virtual string GenusName => "Dermochelys";

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
