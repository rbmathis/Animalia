using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Staphida;

/// <summary>
/// Abstract class for Staphida (genus).
/// NCBI TaxId: 2823204
/// </summary>
public abstract class Staphida : Zosteropidae, IStaphida
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Staphida";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823204;

    /// <inheritdoc />
    public virtual string GenusName => "Staphida";

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
