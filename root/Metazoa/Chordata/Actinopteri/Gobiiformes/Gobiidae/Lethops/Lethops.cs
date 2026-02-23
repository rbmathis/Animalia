using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Lethops;

/// <summary>
/// Abstract class for Lethops (genus).
/// NCBI TaxId: 314004
/// </summary>
public abstract class Lethops : Gobiidae, ILethops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lethops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 314004;

    /// <inheritdoc />
    public virtual string GenusName => "Lethops";

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
