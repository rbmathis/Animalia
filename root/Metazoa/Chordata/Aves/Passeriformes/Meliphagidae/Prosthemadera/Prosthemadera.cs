using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Prosthemadera;

/// <summary>
/// Abstract class for Prosthemadera (genus).
/// NCBI TaxId: 266373
/// </summary>
public abstract class Prosthemadera : Meliphagidae, IProsthemadera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prosthemadera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266373;

    /// <inheritdoc />
    public virtual string GenusName => "Prosthemadera";

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
