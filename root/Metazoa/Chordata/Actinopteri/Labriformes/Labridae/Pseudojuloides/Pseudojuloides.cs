using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Pseudojuloides;

/// <summary>
/// Abstract class for Pseudojuloides (genus).
/// NCBI TaxId: 241338
/// </summary>
public abstract class Pseudojuloides : Labridae, IPseudojuloides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudojuloides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241338;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudojuloides";

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
