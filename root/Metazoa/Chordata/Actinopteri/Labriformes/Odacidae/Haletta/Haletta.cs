using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Odacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Odacidae.Haletta;

/// <summary>
/// Abstract class for Haletta (genus).
/// NCBI TaxId: 241356
/// </summary>
public abstract class Haletta : Odacidae, IHaletta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haletta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241356;

    /// <inheritdoc />
    public virtual string GenusName => "Haletta";

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
