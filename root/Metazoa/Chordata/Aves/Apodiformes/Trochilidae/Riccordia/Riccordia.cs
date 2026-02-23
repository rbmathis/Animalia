using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Riccordia;

/// <summary>
/// Abstract class for Riccordia (genus).
/// NCBI TaxId: 3018374
/// </summary>
public abstract class Riccordia : Trochilidae, IRiccordia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Riccordia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3018374;

    /// <inheritdoc />
    public virtual string GenusName => "Riccordia";

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
