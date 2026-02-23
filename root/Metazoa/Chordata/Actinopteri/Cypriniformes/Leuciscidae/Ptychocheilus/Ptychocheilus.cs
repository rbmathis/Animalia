using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Ptychocheilus;

/// <summary>
/// Abstract class for Ptychocheilus (genus).
/// NCBI TaxId: 71768
/// </summary>
public abstract class Ptychocheilus : Leuciscidae, IPtychocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptychocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71768;

    /// <inheritdoc />
    public virtual string GenusName => "Ptychocheilus";

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
