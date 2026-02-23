using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Champsochromis;

/// <summary>
/// Abstract class for Champsochromis (genus).
/// NCBI TaxId: 32495
/// </summary>
public abstract class Champsochromis : Cichlidae, IChampsochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Champsochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32495;

    /// <inheritdoc />
    public virtual string GenusName => "Champsochromis";

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
