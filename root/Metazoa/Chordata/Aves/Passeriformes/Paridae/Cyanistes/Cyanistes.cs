using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Cyanistes;

/// <summary>
/// Abstract class for Cyanistes (genus).
/// NCBI TaxId: 156562
/// </summary>
public abstract class Cyanistes : Paridae, ICyanistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyanistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 156562;

    /// <inheritdoc />
    public virtual string GenusName => "Cyanistes";

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
