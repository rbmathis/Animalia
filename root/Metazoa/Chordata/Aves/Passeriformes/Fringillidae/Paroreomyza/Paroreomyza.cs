using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Paroreomyza;

/// <summary>
/// Abstract class for Paroreomyza (genus).
/// NCBI TaxId: 64810
/// </summary>
public abstract class Paroreomyza : Fringillidae, IParoreomyza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paroreomyza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 64810;

    /// <inheritdoc />
    public virtual string GenusName => "Paroreomyza";

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
