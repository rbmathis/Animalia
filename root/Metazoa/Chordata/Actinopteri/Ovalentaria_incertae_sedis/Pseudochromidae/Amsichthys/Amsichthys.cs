using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Amsichthys;

/// <summary>
/// Abstract class for Amsichthys (genus).
/// NCBI TaxId: 1609615
/// </summary>
public abstract class Amsichthys : Pseudochromidae, IAmsichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amsichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1609615;

    /// <inheritdoc />
    public virtual string GenusName => "Amsichthys";

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
