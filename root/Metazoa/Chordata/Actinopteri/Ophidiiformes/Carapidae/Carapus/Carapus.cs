using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Carapidae.Carapus;

/// <summary>
/// Abstract class for Carapus (genus).
/// NCBI TaxId: 181392
/// </summary>
public abstract class Carapus : Carapidae, ICarapus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carapus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181392;

    /// <inheritdoc />
    public virtual string GenusName => "Carapus";

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
