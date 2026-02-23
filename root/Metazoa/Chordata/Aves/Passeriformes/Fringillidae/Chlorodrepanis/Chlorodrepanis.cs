using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Chlorodrepanis;

/// <summary>
/// Abstract class for Chlorodrepanis (genus).
/// NCBI TaxId: 2821307
/// </summary>
public abstract class Chlorodrepanis : Fringillidae, IChlorodrepanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlorodrepanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821307;

    /// <inheritdoc />
    public virtual string GenusName => "Chlorodrepanis";

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
