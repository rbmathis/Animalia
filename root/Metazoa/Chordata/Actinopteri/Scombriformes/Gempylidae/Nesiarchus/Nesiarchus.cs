using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Nesiarchus;

/// <summary>
/// Abstract class for Nesiarchus (genus).
/// NCBI TaxId: 372797
/// </summary>
public abstract class Nesiarchus : Gempylidae, INesiarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesiarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 372797;

    /// <inheritdoc />
    public virtual string GenusName => "Nesiarchus";

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
