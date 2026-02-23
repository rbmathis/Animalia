using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Phytotoma;

/// <summary>
/// Abstract class for Phytotoma (genus).
/// NCBI TaxId: 137533
/// </summary>
public abstract class Phytotoma : Cotingidae, IPhytotoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phytotoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 137533;

    /// <inheritdoc />
    public virtual string GenusName => "Phytotoma";

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
