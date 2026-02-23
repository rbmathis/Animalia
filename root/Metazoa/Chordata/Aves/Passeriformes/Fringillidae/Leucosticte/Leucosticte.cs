using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Leucosticte;

/// <summary>
/// Abstract class for Leucosticte (genus).
/// NCBI TaxId: 190693
/// </summary>
public abstract class Leucosticte : Fringillidae, ILeucosticte
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leucosticte";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190693;

    /// <inheritdoc />
    public virtual string GenusName => "Leucosticte";

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
