using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Menuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Menuridae.Menura;

/// <summary>
/// Abstract class for Menura (genus).
/// NCBI TaxId: 47691
/// </summary>
public abstract class Menura : Menuridae, IMenura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Menura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 47691;

    /// <inheritdoc />
    public virtual string GenusName => "Menura";

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
