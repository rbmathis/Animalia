using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Bryaninops;

/// <summary>
/// Abstract class for Bryaninops (genus).
/// NCBI TaxId: 595626
/// </summary>
public abstract class Bryaninops : Gobiidae, IBryaninops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bryaninops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 595626;

    /// <inheritdoc />
    public virtual string GenusName => "Bryaninops";

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
