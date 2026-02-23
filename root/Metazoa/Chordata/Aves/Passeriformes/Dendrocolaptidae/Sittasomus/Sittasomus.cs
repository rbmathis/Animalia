using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae.Sittasomus;

/// <summary>
/// Abstract class for Sittasomus (genus).
/// NCBI TaxId: 75972
/// </summary>
public abstract class Sittasomus : Dendrocolaptidae, ISittasomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sittasomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75972;

    /// <inheritdoc />
    public virtual string GenusName => "Sittasomus";

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
