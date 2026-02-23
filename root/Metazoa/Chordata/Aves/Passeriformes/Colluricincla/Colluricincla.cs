using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Colluricincla;

/// <summary>
/// Abstract class for Colluricincla (genus).
/// NCBI TaxId: 156159
/// </summary>
public abstract class Colluricincla : Passeriformes, IColluricincla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Colluricincla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 156159;

    /// <inheritdoc />
    public virtual string GenusName => "Colluricincla";

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
