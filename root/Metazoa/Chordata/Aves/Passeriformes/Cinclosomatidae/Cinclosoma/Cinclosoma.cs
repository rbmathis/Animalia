using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclosomatidae.Cinclosoma;

/// <summary>
/// Abstract class for Cinclosoma (genus).
/// NCBI TaxId: 461242
/// </summary>
public abstract class Cinclosoma : Cinclosomatidae, ICinclosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cinclosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 461242;

    /// <inheritdoc />
    public virtual string GenusName => "Cinclosoma";

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
