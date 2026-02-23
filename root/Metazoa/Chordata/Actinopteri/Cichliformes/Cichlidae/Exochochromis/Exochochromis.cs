using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Exochochromis;

/// <summary>
/// Abstract class for Exochochromis (genus).
/// NCBI TaxId: 163625
/// </summary>
public abstract class Exochochromis : Cichlidae, IExochochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Exochochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163625;

    /// <inheritdoc />
    public virtual string GenusName => "Exochochromis";

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
