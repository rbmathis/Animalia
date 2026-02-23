using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Aegithalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Aegithalidae.Aegithina;

/// <summary>
/// Abstract class for Aegithina (genus).
/// NCBI TaxId: 175020
/// </summary>
public abstract class Aegithina : Aegithalidae, IAegithina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aegithina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175020;

    /// <inheritdoc />
    public virtual string GenusName => "Aegithina";

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
