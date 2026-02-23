using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Etmopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Etmopteridae.Aculeola;

/// <summary>
/// Abstract class for Aculeola (genus).
/// NCBI TaxId: 862895
/// </summary>
public abstract class Aculeola : Etmopteridae, IAculeola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aculeola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 862895;

    /// <inheritdoc />
    public virtual string GenusName => "Aculeola";

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
