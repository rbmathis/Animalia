using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Aioliops;

/// <summary>
/// Abstract class for Aioliops (genus).
/// NCBI TaxId: 1559955
/// </summary>
public abstract class Aioliops : Gobiidae, IAioliops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aioliops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1559955;

    /// <inheritdoc />
    public virtual string GenusName => "Aioliops";

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
