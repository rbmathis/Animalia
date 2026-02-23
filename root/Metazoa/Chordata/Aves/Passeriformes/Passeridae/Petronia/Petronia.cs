using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Petronia;

/// <summary>
/// Abstract class for Petronia (genus).
/// NCBI TaxId: 150912
/// </summary>
public abstract class Petronia : Passeridae, IPetronia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petronia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150912;

    /// <inheritdoc />
    public virtual string GenusName => "Petronia";

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
