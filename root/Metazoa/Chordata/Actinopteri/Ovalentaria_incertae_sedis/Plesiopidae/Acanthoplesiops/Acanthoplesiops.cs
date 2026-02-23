using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae.Acanthoplesiops;

/// <summary>
/// Abstract class for Acanthoplesiops (genus).
/// NCBI TaxId: 1609617
/// </summary>
public abstract class Acanthoplesiops : Plesiopidae, IAcanthoplesiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthoplesiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1609617;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthoplesiops";

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
