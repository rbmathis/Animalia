using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Zanda;

/// <summary>
/// Abstract class for Zanda (genus).
/// NCBI TaxId: 2818394
/// </summary>
public abstract class Zanda : Cacatuidae, IZanda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zanda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2818394;

    /// <inheritdoc />
    public virtual string GenusName => "Zanda";

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
