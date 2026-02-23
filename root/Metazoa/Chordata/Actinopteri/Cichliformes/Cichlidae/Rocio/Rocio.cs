using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Rocio;

/// <summary>
/// Abstract class for Rocio (genus).
/// NCBI TaxId: 661981
/// </summary>
public abstract class Rocio : Cichlidae, IRocio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rocio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 661981;

    /// <inheritdoc />
    public virtual string GenusName => "Rocio";

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
