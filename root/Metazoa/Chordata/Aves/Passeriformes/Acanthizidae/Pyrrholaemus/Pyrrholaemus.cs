using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae.Pyrrholaemus;

/// <summary>
/// Abstract class for Pyrrholaemus (genus).
/// NCBI TaxId: 720577
/// </summary>
public abstract class Pyrrholaemus : Acanthizidae, IPyrrholaemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyrrholaemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 720577;

    /// <inheritdoc />
    public virtual string GenusName => "Pyrrholaemus";

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
