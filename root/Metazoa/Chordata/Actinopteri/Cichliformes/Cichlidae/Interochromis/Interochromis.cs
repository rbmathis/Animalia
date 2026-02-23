using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Interochromis;

/// <summary>
/// Abstract class for Interochromis (genus).
/// NCBI TaxId: 683191
/// </summary>
public abstract class Interochromis : Cichlidae, IInterochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Interochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 683191;

    /// <inheritdoc />
    public virtual string GenusName => "Interochromis";

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
