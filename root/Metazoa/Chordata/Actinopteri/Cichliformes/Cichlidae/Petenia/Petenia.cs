using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Petenia;

/// <summary>
/// Abstract class for Petenia (genus).
/// NCBI TaxId: 96997
/// </summary>
public abstract class Petenia : Cichlidae, IPetenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 96997;

    /// <inheritdoc />
    public virtual string GenusName => "Petenia";

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
