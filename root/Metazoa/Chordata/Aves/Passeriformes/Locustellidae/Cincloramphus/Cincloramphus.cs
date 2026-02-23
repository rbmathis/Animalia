using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae.Cincloramphus;

/// <summary>
/// Abstract class for Cincloramphus (genus).
/// NCBI TaxId: 237417
/// </summary>
public abstract class Cincloramphus : Locustellidae, ICincloramphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cincloramphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 237417;

    /// <inheritdoc />
    public virtual string GenusName => "Cincloramphus";

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
