using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Steatocranus;

/// <summary>
/// Abstract class for Steatocranus (genus).
/// NCBI TaxId: 64556
/// </summary>
public abstract class Steatocranus : Cichlidae, ISteatocranus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Steatocranus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 64556;

    /// <inheritdoc />
    public virtual string GenusName => "Steatocranus";

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
