using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Orthochromis;

/// <summary>
/// Abstract class for Orthochromis (genus).
/// NCBI TaxId: 167843
/// </summary>
public abstract class Orthochromis : Cichlidae, IOrthochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orthochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 167843;

    /// <inheritdoc />
    public virtual string GenusName => "Orthochromis";

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
