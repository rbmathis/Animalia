using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Salaria;

/// <summary>
/// Abstract class for Salaria (genus).
/// NCBI TaxId: 152552
/// </summary>
public abstract class Salaria : Blenniidae, ISalaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Salaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 152552;

    /// <inheritdoc />
    public virtual string GenusName => "Salaria";

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
