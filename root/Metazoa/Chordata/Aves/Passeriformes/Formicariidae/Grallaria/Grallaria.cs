using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae.Grallaria;

/// <summary>
/// Abstract class for Grallaria (genus).
/// NCBI TaxId: 117144
/// </summary>
public abstract class Grallaria : Formicariidae, IGrallaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grallaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117144;

    /// <inheritdoc />
    public virtual string GenusName => "Grallaria";

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
