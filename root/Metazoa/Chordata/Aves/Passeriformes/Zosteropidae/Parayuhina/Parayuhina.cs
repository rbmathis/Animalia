using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Parayuhina;

/// <summary>
/// Abstract class for Parayuhina (genus).
/// NCBI TaxId: 2817430
/// </summary>
public abstract class Parayuhina : Zosteropidae, IParayuhina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parayuhina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2817430;

    /// <inheritdoc />
    public virtual string GenusName => "Parayuhina";

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
