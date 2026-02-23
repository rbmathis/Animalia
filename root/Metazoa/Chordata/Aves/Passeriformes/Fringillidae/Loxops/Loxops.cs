using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Loxops;

/// <summary>
/// Abstract class for Loxops (genus).
/// NCBI TaxId: 64803
/// </summary>
public abstract class Loxops : Fringillidae, ILoxops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loxops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 64803;

    /// <inheritdoc />
    public virtual string GenusName => "Loxops";

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
