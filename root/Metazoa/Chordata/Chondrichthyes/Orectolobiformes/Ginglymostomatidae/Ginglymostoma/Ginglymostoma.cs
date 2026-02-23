using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Ginglymostomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Ginglymostomatidae.Ginglymostoma;

/// <summary>
/// Abstract class for Ginglymostoma (genus).
/// NCBI TaxId: 7800
/// </summary>
public abstract class Ginglymostoma : Ginglymostomatidae, IGinglymostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ginglymostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7800;

    /// <inheritdoc />
    public virtual string GenusName => "Ginglymostoma";

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
