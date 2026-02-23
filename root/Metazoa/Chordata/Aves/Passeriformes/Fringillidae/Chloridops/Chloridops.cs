using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Chloridops;

/// <summary>
/// Abstract class for Chloridops (genus).
/// NCBI TaxId: 3036774
/// </summary>
public abstract class Chloridops : Fringillidae, IChloridops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chloridops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3036774;

    /// <inheritdoc />
    public virtual string GenusName => "Chloridops";

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
