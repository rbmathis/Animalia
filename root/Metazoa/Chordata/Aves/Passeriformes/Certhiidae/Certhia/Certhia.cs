using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Certhia;

/// <summary>
/// Abstract class for Certhia (genus).
/// NCBI TaxId: 73329
/// </summary>
public abstract class Certhia : Certhiidae, ICerthia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Certhia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 73329;

    /// <inheritdoc />
    public virtual string GenusName => "Certhia";

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
