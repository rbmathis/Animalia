using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae.Plesiops;

/// <summary>
/// Abstract class for Plesiops (genus).
/// NCBI TaxId: 270569
/// </summary>
public abstract class Plesiops : Plesiopidae, IPlesiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plesiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270569;

    /// <inheritdoc />
    public virtual string GenusName => "Plesiops";

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
