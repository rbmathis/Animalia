using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Bujurquina;

/// <summary>
/// Abstract class for Bujurquina (genus).
/// NCBI TaxId: 74451
/// </summary>
public abstract class Bujurquina : Cichlidae, IBujurquina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bujurquina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74451;

    /// <inheritdoc />
    public virtual string GenusName => "Bujurquina";

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
