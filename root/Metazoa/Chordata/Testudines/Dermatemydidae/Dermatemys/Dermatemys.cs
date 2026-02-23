using AnimalKingdom.root.Metazoa.Chordata.Testudines.Dermatemydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Dermatemydidae.Dermatemys;

/// <summary>
/// Abstract class for Dermatemys (genus).
/// NCBI TaxId: 55549
/// </summary>
public abstract class Dermatemys : Dermatemydidae, IDermatemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dermatemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55549;

    /// <inheritdoc />
    public virtual string GenusName => "Dermatemys";

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
