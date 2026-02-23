using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae.Calloplesiops;

/// <summary>
/// Abstract class for Calloplesiops (genus).
/// NCBI TaxId: 302766
/// </summary>
public abstract class Calloplesiops : Plesiopidae, ICalloplesiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calloplesiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 302766;

    /// <inheritdoc />
    public virtual string GenusName => "Calloplesiops";

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
