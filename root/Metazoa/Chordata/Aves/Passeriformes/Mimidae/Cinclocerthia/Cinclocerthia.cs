using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Cinclocerthia;

/// <summary>
/// Abstract class for Cinclocerthia (genus).
/// NCBI TaxId: 58196
/// </summary>
public abstract class Cinclocerthia : Mimidae, ICinclocerthia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cinclocerthia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58196;

    /// <inheritdoc />
    public virtual string GenusName => "Cinclocerthia";

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
