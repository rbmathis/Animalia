using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Opistognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Opistognathidae.Stalix;

/// <summary>
/// Abstract class for Stalix (genus).
/// NCBI TaxId: 2768225
/// </summary>
public abstract class Stalix : Opistognathidae, IStalix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stalix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2768225;

    /// <inheritdoc />
    public virtual string GenusName => "Stalix";

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
