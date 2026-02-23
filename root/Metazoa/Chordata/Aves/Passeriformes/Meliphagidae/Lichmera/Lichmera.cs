using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Lichmera;

/// <summary>
/// Abstract class for Lichmera (genus).
/// NCBI TaxId: 266361
/// </summary>
public abstract class Lichmera : Meliphagidae, ILichmera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lichmera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266361;

    /// <inheritdoc />
    public virtual string GenusName => "Lichmera";

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
