using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Heteroxolmis;

/// <summary>
/// Abstract class for Heteroxolmis (genus).
/// NCBI TaxId: 1118856
/// </summary>
public abstract class Heteroxolmis : Tyrannidae, IHeteroxolmis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heteroxolmis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1118856;

    /// <inheritdoc />
    public virtual string GenusName => "Heteroxolmis";

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
